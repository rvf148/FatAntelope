using Microsoft.Web.XmlTransform;
using System;
using System.Text;

namespace XDT_Tool
{
    public class TransformationLogger : IXmlTransformationLogger
    {
        private StringBuilder contentBuilder = new StringBuilder();
        public string Content {
            get
            {
                return contentBuilder.ToString();
            }
        }

        public MessageType FilterMessageType { get; set; }

        public void EndSection(string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine(string.Format(message, messageArgs));
        }

        public void EndSection(MessageType type, string message, params object[] messageArgs)
        {
            if (FilterMessageType == type)
                contentBuilder.AppendLine(string.Format(message, messageArgs));
        }

        public void LogError(string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine("ERROR " + string.Format(message, messageArgs));
        }

        public void LogError(string file, string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine($"ERROR {file} " + string.Format(message, messageArgs));
        }

        public void LogError(string file, int lineNumber, int linePosition, string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine($"ERROR {file} Line:{lineNumber} Pos:{linePosition}" + string.Format(message, messageArgs));
        }

        public void LogErrorFromException(Exception ex)
        {
            contentBuilder.AppendLine($"EXCEPTION: {ex.Message}");
        }

        public void LogErrorFromException(Exception ex, string file)
        {
            contentBuilder.AppendLine($"EXCEPTION: {file} {ex.Message}");
        }

        public void LogErrorFromException(Exception ex, string file, int lineNumber, int linePosition)
        {
            contentBuilder.AppendLine($"EXCEPTION: {file} Line:{lineNumber} Pos:{linePosition} {ex.Message} ");

        }

        public void LogMessage(string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine(string.Format(message, messageArgs));
        }

        public void LogMessage(MessageType type, string message, params object[] messageArgs)
        {
            if (FilterMessageType == type)
                contentBuilder.AppendLine(string.Format(message, messageArgs));
        }

        public void LogWarning(string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine("WARNING " + string.Format(message, messageArgs));
        }

        public void LogWarning(string file, string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine($"WARNING {file} " + string.Format(message, messageArgs));
        }

        public void LogWarning(string file, int lineNumber, int linePosition, string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine($"WARNING: {file} Line:{lineNumber} Pos:{linePosition}"  + string.Format(message, messageArgs));
        }

        public void StartSection(string message, params object[] messageArgs)
        {
            contentBuilder.AppendLine(string.Format(message, messageArgs));
        }

        public void StartSection(MessageType type, string message, params object[] messageArgs)
        {
            if (FilterMessageType == type)
                contentBuilder.AppendLine(string.Format(message, messageArgs));
        }
    }
}
