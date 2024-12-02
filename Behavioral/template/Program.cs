
public class Template
{
    public abstract class Video
    {
        public void ProcessVideo()
        {
            EnhanceVideoQuality();
            ApplyColorCorrection();
            EnhanceAudioQuality();
            ApplyFilter();
            RenderVideo();
        }

        protected abstract void RenderVideo();

        private void EnhanceVideoQuality()
        {
            Console.WriteLine("Enhance video quality to HD");
        }

        private void ApplyColorCorrection()
        {
            Console.WriteLine("Applying color correction");
        }

        private void EnhanceAudioQuality()
        {
            Console.WriteLine("Enhance audio quality");
        }

        private void ApplyFilter()
        {
            Console.WriteLine("Applying filters");
        }
    }

    public class Hd : Video
    {
        protected override void RenderVideo()
        {
            Console.WriteLine("Render video in HD quality");
        }
    }

    public class FHD : Video
    {
        protected override void RenderVideo()
        {
            Console.WriteLine("Rendering video in FHD quality");
        }
    }

    public class SD : Video
    {
        protected override void RenderVideo()
        {
            Console.WriteLine("Rendering video in SD quality");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Video hd = new Hd();
            hd.ProcessVideo();

            Video sd = new SD();
            sd.ProcessVideo();

            Video fhd = new FHD();
            fhd.ProcessVideo();
        }
    }
}
