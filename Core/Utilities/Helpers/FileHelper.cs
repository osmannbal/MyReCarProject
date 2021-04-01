using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile formFile)
        {
            var sourcepath = Path.GetTempFileName();
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }

            var result = newPath(formFile);
            File.Move(sourcepath, result.path2);
            return result.path2;
        }

        public static string UpdateAsync(string sourcepath, IFormFile formFile)
        {
            var result = newPath(formFile);
            File.Copy(sourcepath, result.path2);

            File.Delete(sourcepath);
            return result.path2;
        }

        public static IResult Delete(string sourcepath)
        {
            try
            {
                File.Delete(sourcepath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }

        private static (string path, string path2) newPath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            string FileExtension = fileInfo.Extension;

            var newPath = Guid.NewGuid()+ FileExtension;

            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            string result = $@"{path}\{newPath}";
            return (result, $"\\Images\\{newPath}");

        }
    }
}
