using System;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature; // 필드선언
        
        public void SetTemperature(int temperature) // 메서드 선언
        {
            if (temperature < -5 || temperature > 42) // 이 온도 밖에 있으면 예외처리
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature; // ??
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
        
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50); // 예외처리
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

//Turn on water : 20
//Turn on water : -2
//Out of temperature range