using System.Collections.Generic;

namespace Visitor.Exercise.Start
{
    /// <summary>
    /// We’re going to build an audio editor for editing wave (.wav) files. 
    /// We’re planning to ship this application with a bunch of standard filters that users can apply on their audio files, such as:
    ///     - Noise reduction 
    ///     - Reverb
    ///     - Normalize 
    /// We want other developers to be able to create new filters in the form of plugins that can be imported into our application.  
    /// Look at this WavFile class: 
    ///     - What are the problems with this implementation?  
    ///     - Can the visitor pattern solve these problems? Why?  
    ///     - Refactor the code and apply the visitor pattern.
    /// </summary>
    public class WavFile
    {
        private readonly List<Segment> segments = new List<Segment>();

        public static WavFile Read(string fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void ReduceNoise()
        {
            foreach(var segment in segments)
            {
                segment.ReduceNoise();
            }
        }

        public void AddReverb()
        {
            foreach (var segment in segments)
            {
                segment.AddReverb();
            }
        }

        public void Normalize()
        {
            foreach (var segment in segments)
            {
                segment.Normalize();
            }
        }
    }
}
