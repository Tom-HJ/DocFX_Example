using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFX_Test
{
    /// <summary>
    /// 기능 클래스
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Singleton
        /// </summary>
        private static Function instance;
        /// <summary>
        /// 다중 스레드로부터 하나의 스레드만 안전하게 실행할 수 있도록.
        /// </summary>
        private static readonly object padlock = new object();
        /// <summary>
        /// public Singleton
        /// </summary>
        public static Function Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        instance = new Function();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// 태그
        /// </summary>
        private string TAG = "[Function.cs] ";

        /// <summary>
        /// [220117] (Tom-HJ) 테스트 함수.
        /// </summary>
        /// <remarks>
        /// 콘솔에 테스트 글자를 출력함.
        /// </remarks>
        public void Test()
        {
            Console.WriteLine("Test");
        }

        /// <summary>
        /// [220117] (Tom-HJ) 프로세스가 켜져있으면 닫음.
        /// </summary>
        /// <param name="processName">끄고자 하는 프로세스 이름</param>
        public void CloseProcess(string processName)
        {
            var process = Process.GetProcessesByName(processName);
            try
            {
                if (process.Length > 0)
                {
                    for (int i = 0; i < process.Length; i++) process[i].Kill();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{TAG}CloseProcess() -> Process Error: {e.StackTrace}");
            }
        }
    }
}
