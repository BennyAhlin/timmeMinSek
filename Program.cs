int hour = 0;
int min = 0;
int sec = 0;


	for (int benny = 0; hour < 24; benny++)
	{

		if (hour < 10)
		{
            Console.Write("0" + hour + ":");
        }
		else
		{
            Console.Write(hour + ":");
		}
        if (min < 10)
        {
            Console.Write("0" + min + ":");
        }
        else
        {
            Console.Write(min + ":");
        }
        if (sec < 10)
        {
            Console.WriteLine("0" + sec);
        }
        else
        {
            Console.WriteLine(sec);
        }
        if (sec < 60)
        {
            sec++;

            if (sec == 60)   
            {
                min++;
                sec = 0;

                if (min == 60)
                {
                    hour++;
                    min = 0;
                }

            }
        }




    }




