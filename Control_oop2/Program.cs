using System;

namespace Control_oop2
{
    class Program
    {
        struct computer
        {
            public struct processor // Процесор
            {
                public string CPU_view;
                public float CPU_ghz;
                public float CPU_drive;
                public float CPU_price;

                public void cpu_display()
                {
                    Console.WriteLine($"System units:\nType of processor: {CPU_view}");
                    Console.WriteLine($"Clock frequency: {CPU_ghz}");
                    Console.WriteLine($"Hard drive volume: {CPU_drive}");
                    Console.WriteLine($"Price: {CPU_price}$");
                }
            }

            public struct monitor
            {
                public float led_diagonal;
                public int led_resolution_x;
                public int led_resolution_y;
                public float led_price;

                public void led_display()
                {
                    Console.WriteLine("_____________");
                    Console.WriteLine($"Monior:\nDiagonal: {led_diagonal}");
                    Console.WriteLine($"Resolution {led_resolution_x}x{led_resolution_y}");
                    Console.WriteLine($"Price: {led_price}$");
                }
            }

            public struct keyboard
            {
                public string board_type;
                public int board_keys;
                public float board_price;

                public void board_display()
                {
                    Console.WriteLine("_____________");
                    Console.WriteLine($"Keyboard:\nType: {board_type}");
                    Console.WriteLine($"Number of keys: {board_keys}");
                    Console.WriteLine($"Price: {board_price}$");
                }
            }

            public struct mouse
            {
                public string mouse_type;
                public int mouse_keys;
                public float mouse_price;

                public void mouse_display()
                {
                    Console.WriteLine("_____________");
                    Console.WriteLine($"Mouse:\nType: {mouse_type}");
                    Console.WriteLine($"Number of keys: {mouse_keys}");
                    Console.WriteLine($"Price: {mouse_price}");
                }
            }
        }

        static void Main(string[] args)
        {
            //Процесор
            computer.processor cpu;
            cpu.CPU_view = "Buffer processor";
            cpu.CPU_ghz = 3.2f;
            cpu.CPU_drive = 499.5f;
            cpu.CPU_price = 200.00f;
            cpu.cpu_display();
            //Монітор
            computer.monitor led;
            led.led_diagonal = 14.5f;
            led.led_resolution_x = 1200;
            led.led_resolution_y = 800;
            led.led_price = 159.00f;
            led.led_display();
            //Клавіатура
            computer.keyboard kb;
            kb.board_type = "mechanical";
            kb.board_keys = 72;
            kb.board_price = 69.99f;
            kb.board_display();
            //Мишка
            computer.mouse m;
            m.mouse_type = "optical";
            m.mouse_keys = 4;
            m.mouse_price = 35.8f;
            m.mouse_display();
            //------------------//
            float sum = cpu.CPU_price + led.led_price + kb.board_price + m.mouse_price;
            sum = (float)Math.Round(sum, 2);
            Console.WriteLine("______________");
            Console.WriteLine($"The sum of all purchases:{sum}");
        }
    }
}
