using System.Text;
public class TestLogger
{
    private readonly StringBuilder logBuilder = new StringBuilder();

    public void Log(string message, bool passed)
    {
        // Determine the tag based on the passed status
        string tag = passed ? "Pass" : "Fail";
        
        // Append the message with the corresponding tag
        logBuilder.AppendLine($"<{tag}>{message}</{tag}>");
    }

    public void GenerateHtmlReport(string reportPath)
    {
        using (StreamWriter sw = new StreamWriter(reportPath))
        {
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("<title>Test Report</title>");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>Test Report</h1>");
            sw.WriteLine("<ul>");
            // Split the log by new lines and output each line as a list item
            foreach (string line in logBuilder.ToString().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                sw.WriteLine($"<li>{line}</li>");
            }
            sw.WriteLine("</ul>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
        }
    }
}

