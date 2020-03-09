using System;
using System.Collections.Generic;
using System.IO;

namespace OrganizingData
{
    public class Practice
    {
        public class Animation
        {
            public bool IsPlaying { get; set; }
            public int StartFrame { get; set; }
            public int EndFrame { get; set; }
            public Dictionary<string,Animation> ChildAnimations { get; set; }
        }

        public void ReadAnimations(Animation baseAnimation, string animationFile)
        {
            using StreamReader file = new StreamReader(animationFile);

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] parts = line.Split(' ');
                string name = !string.IsNullOrWhiteSpace(parts[0]) ? parts[0] : $"ChildAnimation {Guid.NewGuid()}";

                int startFrame = int.Parse(parts[1]);
                int endFrame = int.Parse(parts[2]);

                baseAnimation.ChildAnimations[name] = new Animation
                {
                    StartFrame = startFrame,
                    EndFrame = endFrame
                };
            }
        }
    }
}
