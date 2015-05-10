set message=%1
git add .
git commit -a -m %message%
git push -u origin master
PAUSE