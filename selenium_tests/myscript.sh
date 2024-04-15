sudo -S apt-get update
sudo -S apt-get install -y dotnet-sdk-8.0
sudo dotnet test  /var/lib/jenkins/workspace/Web_Automation/selenium_tests/bin/Debug/net8.0/selenium_tests.dll --logger html
