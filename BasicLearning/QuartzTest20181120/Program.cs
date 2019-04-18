using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzTest20181120
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAsyncJob();
            Console.ReadKey();
        }
        static async Task TestAsyncJob()
        {
            var props = new NameValueCollection { { "quartz.serializer.type", "binary" } };
            StdSchedulerFactory schedFact = new StdSchedulerFactory(props);

            IScheduler sched = await schedFact.GetScheduler();
            await sched.Start();

            IJobDetail job = JobBuilder.Create<AlexSimpleJob>().WithIdentity("AlexJob", "AlexGroup").Build();
            IJobDetail anotherjob = JobBuilder.Create<AlexAnotherSimpleJob>().WithIdentity("AlexAnotherJob", "AlexGroup").Build();

            ITrigger trigger = TriggerBuilder.Create().WithIdentity("AlexTrigger", "AlexGroup")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();
            ITrigger anothertrigger = TriggerBuilder.Create().WithIdentity("AlexAnotherTrigger", "AlexGroup")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

            await sched.ScheduleJob(job, trigger);
            await sched.ScheduleJob(anotherjob, anothertrigger);

        }
    }
    public class AlexSimpleJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("hello alex,job executed.");
            return Task.CompletedTask;
        }
    }
    public class AlexAnotherSimpleJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            string filePath = @"c:\timertes.txt";
            if (!File.Exists(filePath))
            {
                using (FileStream fs=File.Create(filePath)) { }
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(DateTime.Now.ToLongTimeString());
            }
            return Task.CompletedTask;
        }
    }

    
}
