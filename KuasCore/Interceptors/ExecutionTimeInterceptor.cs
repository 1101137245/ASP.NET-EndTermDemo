using AopAlliance.Intercept;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Interceptors
{
    class ExecutionTimeInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("ExecutionTimeInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("ExecutionTimeInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            object result = invocation.Proceed();

            stopwatch.Stop();
            Console.WriteLine("Time : " + stopwatch.ElapsedMilliseconds + " ms.");
            Debug.Print("Time : " + stopwatch.ElapsedMilliseconds + " ms.");

            return result;
        }

    }
}
