stack test

if [ $? -eq 0 ]
then
    git add .
    git commit -m "$1"
else
    git reset --hard HEAD
fi
