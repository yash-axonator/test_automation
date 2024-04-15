wget -q https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
dpkg -i packages-microsoft-prod.deb
apt-get update
apt-get install -y dotnet-sdk-8.0
dotnet test  /var/lib/jenkins/workspace/Web_Automation/selenium_tests/bin/Debug/net8.0/selenium_tests.dll --logger html
