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
        public static string Add(IFormFile formFile)
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
            File.Move(sourcepath, result);
            return result;
        }

        public static string Update(string sourcepath, IFormFile formFile)
        {
            var result = newPath(formFile);
            if (sourcepath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }

            File.Delete(sourcepath);
            return result;
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

        private static string newPath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            string FileExtension = fileInfo.Extension;

            var creatingUniqueFileName = Guid.NewGuid().ToString("N")
                + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-"
                + DateTime.Now.Year + FileExtension;

            string path = Path.Combine(Environment.CurrentDirectory + @"\Images\Car");
            string result = $@"{path}\{creatingUniqueFileName}";
            return result;

        }
    }
}
