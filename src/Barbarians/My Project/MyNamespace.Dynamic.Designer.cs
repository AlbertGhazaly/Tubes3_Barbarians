using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Barbarians.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BM m_BM;

            public BM BM
            {
                [DebuggerHidden]
                get
                {
                    m_BM = Create__Instance__(m_BM);
                    return m_BM;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BM))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BM);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public KMB m_KMB;

            public KMB KMB
            {
                [DebuggerHidden]
                get
                {
                    m_KMB = Create__Instance__(m_KMB);
                    return m_KMB;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_KMB))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_KMB);
                }
            }

        }


    }
}