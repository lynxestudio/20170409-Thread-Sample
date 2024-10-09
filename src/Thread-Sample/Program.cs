using System.Threading;

Console.WriteLine("================== Simple Thread Sample ==================\n");
            Thread[] workers = {
                new Thread(new ThreadStart(PrintLog10))
                ,new Thread(new ThreadStart(PrintSquared))
};

foreach (var worker in workers) 
{
        worker.Start();
}

static void PrintLog10()  
{
	    var w1StartTime = DateTime.Now;
            for(int i = 1;i <= 11;i++) {
            Console.WriteLine("1st running, printing log10 of {0} :\t[ {1} ]  ",i,Math.Log10(i));
                Thread.Sleep(300);
            }
	    var w1EndTime = DateTime.Now;
	    TimeSpan diffwr1 = w1EndTime.Subtract(w1StartTime);
	    Console.WriteLine("\n\t 1st thread finished in ({0}) milliseconds\n"
        ,diffwr1.TotalMilliseconds);
}

static void PrintSquared() 
{
	    var w2StartTime = DateTime.Now;
             for (int i = 1; i <= 11; i++) {
                 Console.WriteLine("2nd running, printing {0} to the power 2:\t[ {1} ]",i
                 ,Math.Pow(i,2));
                 Thread.Sleep(600);
             }
	    var w2EndTime = DateTime.Now;
	    TimeSpan diffwr2 = w2EndTime.Subtract(w2StartTime);
	    Console.WriteLine("\n\t 2nd thread finished in ({0}) milliseconds\n",diffwr2.TotalMilliseconds);
}