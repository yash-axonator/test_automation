apt-get update
apt-get install -y dotnet-sdk-8.0
dotnet test  /var/lib/jenkins/workspace/Web_Automation/selenium_tests/bin/Debug/net8.0/selenium_tests.dll --logger html
