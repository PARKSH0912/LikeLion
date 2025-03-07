using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class GameManager
    {

        Ball m_pBall = null;

        public void Initialize()
        {
            if (m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }
        }
        public void Progress()
        {
            m_pBall.Progress();
        }
        public void Rendor()
        {
            Console.Clear();
            m_pBall.Render();
        }
        public void Release()
        {
            m_pBall.Release();
        }

    }
}
