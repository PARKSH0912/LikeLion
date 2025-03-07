using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliGate_Event
{
    class Program
    {
        //델리게이트 정의 - 메시지 출력을 위한 메서드참조
        //string 매개변수를 받고 반환값이 없는 (void) 메서드를 참조할 수있는 타입

        delegate void MessageHandler(string Message);

        //델리게이트에 연결할 메서드
        //메서드형과 타입 이런게 일치해야 받아줌

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisPlayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메세지 : {message.ToUpper()}");

        }






        static void Main(string[] args)
        {
            Console.WriteLine("=== 간단한 델리게이트와 이벤트 에제 ===");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트1");

            //델리게이트 변수 선언 및 메서드연결
            //DisplayMessage 메서드를 messageHandler 변수에 할당

            MessageHandler messageHandler = DisplayMessage;

            //델리게이트 호출 - 연결된 메서드가 실행됨
            messageHandler("안녕하세요");

            //델리게이트에 다른 메서드 추가(멀티캐스트 델리게이트)
            // += 연산자로 메서드추가

            messageHandler += DisPlayUpperMessage;

            Console.WriteLine("여러 메서드 호출:");
            messageHandler("Hello");


        }
    }
}
