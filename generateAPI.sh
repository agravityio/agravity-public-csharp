
while getopts v: flag
do
    case "${flag}" in
        v) version=${OPTARG};;
#        a) age=${OPTARG};;
#        f) fullname=${OPTARG};;
    esac
done

# check if version is set
if [ -z "$version" ]
then
      echo "Version is not set"
      exit 1
fi

echo "Generate version: $version"



rm -rf src
npx @openapitools/openapi-generator-cli generate -i http://localhost:7072/api/openapi/v3.json -g csharp-netcore -o . --additional-properties=packageName=Agravity.Public,library=httpclient,targetFramework=netstandard2.0,packageVersion=$version


function replace_in_files()
{
ESCAPED_KEYWORD=$(printf '%s\n' "$1" | sed -e 's/[]\/$*.^[]/\\&/g');
ESCAPED_REPLACE=$(printf '%s\n' "$2" | sed -e 's/[\/&]/\\&/g')
find . -type f -name "*.*" -print0 | xargs -0 sed -i '' -e "$3s/$ESCAPED_KEYWORD/$ESCAPED_REPLACE/g"
}

function replace_in_file()
{
ESCAPED_KEYWORD=$(printf '%s\n' "$1" | sed -e 's/[]\/$*.^[]/\\&/g');
ESCAPED_REPLACE=$(printf '%s\n' "$2" | sed -e 's/[\/&]/\\&/g')
sed -i -e "$4s/$ESCAPED_KEYWORD/$ESCAPED_REPLACE/g" $3
}

replace_in_files "Dictionary<string, object>>" "Dictionary<string, object>>"
replace_in_files "Dictionary&lt;string, object&gt;&gt;" "Dictionary&lt;string, object&gt;&gt;"

# git discard files
git checkout -- Agravity.Public.sln
git checkout -- extract_thirdparty_licenses.bat
git checkout -- icon.png
git checkout -- nuget.exe
git checkout -- openapitools.json
git checkout -- ./src/Agravity.Public/Agravity.Public.nuspec

# replace_in_files "'image/xyz' | 'application/json'}): Observable<string>" "'image/xyz'}): Observable<Blob>" 
# replace_in_files "'image/xyz' | 'application/json'}): Observable<HttpResponse<string>>;" "'image/xyz'}): Observable<HttpResponse<Blob>>;"
# replace_in_files "'image/xyz' | 'application/json'}): Observable<HttpEvent<string>>;" "'image/xyz'}): Observable<HttpEvent<Blob>>;"

#replace_in_file "headers = headers.set('Content-Type', httpContentTypeSelected);" "//headers = headers.set('Content-Type', httpContentTypeSelected);" "v4/agravityAPI-private/api/assetVersioning.agravity.ts" "125,145"
#replace_in_file "headers = headers.set('Content-Type', httpContentTypeSelected);" "//headers = headers.set('Content-Type', httpContentTypeSelected);" "v4\agravityAPI-public\api\publicCollectionSecureUpload.pub.agravity.ts" "200,220"

#linenr=$(awk '/\}\/imageedit/{ print NR; exit }' "v4\agravityAPI-private\api\assetOperations.agravity.ts")
#replace_in_file "<string>" "<Blob>" "v4\agravityAPI-private\api\assetOperations.agravity.ts" $linenr
#linenr2=$(($linenr + 10))
#replace_in_file "responseType: <any>responseType_," "responseType: <any>'blob'," "v4\agravityAPI-private\api\assetOperations.agravity.ts" $linenr,$linenr2

#linenr=$(awk '/\}\/resize/{ print NR; exit }' "v4\agravityAPI-private\api\assetOperations.agravity.ts")
#replace_in_file "<string>" "<Blob>" "v4\agravityAPI-private\api\assetOperations.agravity.ts" $linenr
#linenr2=$(($linenr + 10))
#replace_in_file "responseType: <any>responseType_," "responseType: <any>'blob'," "v4\agravityAPI-private\api\assetOperations.agravity.ts" $linenr,$linenr2
