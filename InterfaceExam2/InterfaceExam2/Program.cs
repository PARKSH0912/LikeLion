using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam2
{
    //인터페이스를 사용하면 기존 코드 변경 없이 새로운 기능추가가 가능함.
    //다양한 결제 시스템 추가(Open-Closed Prirnciple)


    interface IPayment
    {
        void ProccessPayment();
    }



    //신용카드 결제 클래스
    class CreditCatdPayment : IPayment
    {
        public void ProccessPayment()
        {
            Console.WriteLine("신용카드 결제 완료!");
        }
    }


    class Paypal : IPayment
    {

        public void ProccessPayment()
        {
            Console.WriteLine("페이팔 결제 완료");
        }
    }






    class PaymenProcessor
    {

        public void Pay(IPayment payment)
        {
            payment.ProccessPayment();
        }
    }


    //결제처리기 
    class Program
    {
        static void Main(string[] args)
        {

            PaymenProcessor processor = new PaymenProcessor();

            IPayment creditCrad = new CreditCatdPayment();
            IPayment paypal = new Paypal();

            processor.Pay(creditCrad);
            processor.Pay(paypal);

        }
    }
}
