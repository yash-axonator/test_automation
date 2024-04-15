# Give read and write permissions to the Jenkins user for the directory
sudo chmod -R u+rw /home/l21/Documents/qa_automation/selenium_tests/bin/Debug/net8.0/

# Give read and write permissions to the Jenkins user for the file
sudo chmod u+rw /home/l21/Documents/qa_automation/selenium_tests/bin/Debug/net8.0/TestReport.html

(which dotnet) test  /var/lib/jenkins/workspace/web_automation/selenium_tests/bin/Debug/net8.0/selenium_tests.dll --logger html

