using System;
namespace objectsAndClasses
{
    public class PostIt
    {
        public string backgroundColor { get; set; }
        public string textColor { get; set; }
        public string content { get; set; }

        public PostIt()
        {
        }
        public PostIt(string backgroundColor, string textColor, string content)
        {
            this.backgroundColor = backgroundColor;
            this.textColor = textColor;
            this.content = content;
        }
    }
}
