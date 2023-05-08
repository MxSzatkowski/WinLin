using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Wrapper
{
    public class Ent : IDisposable
    {

        //public const string DllPath = @"..\..\..\..\Wraper\bin\Debug\netstandard2.0\CPlusPlus";

        public const string DllPath = @"CPlusPlus";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        static private extern IntPtr CreateTestClass();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        static private extern void DisposeTestClass(IntPtr pTestClassObject);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]

        static private extern float CallAdd(IntPtr pTestClassObject, float a, float b);

        #region Members
        private IntPtr m_pNativeObject;
        #endregion Members

        public Ent()
        {
            this.m_pNativeObject = CreateTestClass();
        }
        public void Dispose()
        {
            Dispose(true);
        }


        protected virtual void Dispose(bool bDisposing)
        {
            if (this.m_pNativeObject != IntPtr.Zero)
            {
                DisposeTestClass(this.m_pNativeObject);
                this.m_pNativeObject = IntPtr.Zero;
            }

            if (bDisposing)
            {
                GC.SuppressFinalize(this);
            }
        }
        
         ~Ent()
         {
             Dispose(false);
         }

         

        public float Add(float a, float b)
        {
            return CallAdd(this.m_pNativeObject, a, b);
        }
    }

}
