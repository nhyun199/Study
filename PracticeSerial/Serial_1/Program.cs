using System;
using System.IO.Ports;

namespace SerialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // SerialPort 클래스 객체 생성 (COM 5포트 사용)
            SerialPort sp = new SerialPort("COM5");

            // 시리얼포트 오픈
            sp.Open();

            // 시리얼포트 한 라인 읽기
            string data = sp.ReadLine();

            // 시리얼포트 닫기
            sp.Close();

            Console.WriteLine("Press Enter to Quit");
            Console.ReadLine();            
        }
    }
}