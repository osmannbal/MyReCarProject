using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation ınvocation) { }
        protected virtual void OnAfter(IInvocation ınvocation) { }
        protected virtual void OnException(IInvocation ınvocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation ınvocation) { }
        public override void Intercept(IInvocation ınvocation)
        {
            var isSuccess = true;
            OnBefore(ınvocation);
            try
            {
                ınvocation.Proceed();
            }
            catch(Exception e)
            {
                isSuccess = false;
                OnException(ınvocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(ınvocation);
                }
            }
            OnAfter(ınvocation);
        }
    }
}
