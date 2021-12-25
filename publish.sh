#!/bin/sh

dotnet publish -c:Release -p:GHPages=true

echo Copy All Published Files to docs ----------------------------

cp -r ./website/bin/Release/net6.0/publish/wwwroot/. ./docs
echo "Done"

echo Create .nojekyll file ---------------------------------------

FILE=./docs/.nojekyll
if [ -f "$FILE" ]; then
    echo "$FILE exists."
else 
    mkfile "$FILE"
    echo "$FILE created."
fi

echo Create .gitattributes file ----------------------------------
FILE=./docs/.gitattributes
if [ -f "$FILE" ]; then
    echo "$FILE exists."
else 
    echo "* -text" > "$FILE"
    echo "$FILE created."
fi

echo Rewrite index.html file -------------------------------------
FILE=./docs/index.html
if [ -f "$FILE" ]; then
    sed -i '.bak' 's!<base href="/" />!<base href="/website/"/>!' "$FILE"
else
    echo "index.html does not exist."
    exit 1
fi

echo Copy index.html to 404.html ---------------------------------
FILE=./docs/index.html
FILE_DIST=./docs/404.html
if [ -f "$FILE" ]; then
    cp "$FILE" "$FILE_DIST"
else
    echo "index.html does not exist."
    exit 2
fi
