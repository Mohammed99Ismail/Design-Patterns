public class Job
{
    public bool IsPassedFormatCheck;
    public bool IsPassedDataSizeCheck;
}

public class JobProcessor
{
    private IJobHandler JobProcessorChain;

    public JobProcessor(IJobHandler jobProcessorChain)
    {
        JobProcessorChain = jobProcessorChain;
    }

    public string ProcessJob(Job job)
    {
        if(JobProcessorChain.Handle(job))
        {
            return "success";
        }

        return "failed";
    }
}

public interface IJobHandler
{
    IJobHandler Next(IJobHandler handler);
    bool Handle(Job job);
}

public abstract class JobHandler : IJobHandler
{
    public IJobHandler? NextHandler { get; set; } = null;
    public virtual bool Handle(Job job)
    {
        if(NextHandler != null)
        {
            return NextHandler.Handle(job);
        }

        return true;
    }

    public IJobHandler Next(IJobHandler handler)
    {
        NextHandler = handler;
        return NextHandler;
    }
}

public class FormatCheckHandler : JobHandler
{
    public override bool Handle(Job job)
    {
        Console.WriteLine("check the format");
        if(!job.IsPassedFormatCheck)
        {
            return false;
        }

        return base.Handle(job);
    }
}

public class DataSizeCheckHandler : JobHandler
{
    public override bool Handle(Job job)
    {
        Console.WriteLine("check data size");
        if(!job.IsPassedDataSizeCheck)
        {
            return false;
        }

        return base.Handle(job);
    }
}


public class Program
{
    public static void Main()
    {
        IJobHandler formatCheckHandler = new FormatCheckHandler();
        IJobHandler dataSizeCheckHandler = new DataSizeCheckHandler();

        formatCheckHandler.Next(dataSizeCheckHandler);

        Job job = new Job { IsPassedFormatCheck = true, IsPassedDataSizeCheck = true };

        JobProcessor pipeLine = new JobProcessor(formatCheckHandler);
        var result = pipeLine.ProcessJob(job);
        Console.WriteLine(result);
    }
}