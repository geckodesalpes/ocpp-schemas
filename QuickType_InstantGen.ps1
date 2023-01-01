# npm install -g quicktype

$baseDir = '2.0.1'

$names = Get-ChildItem "$baseDir/*.json" | Select -Expand Name
$namespace = 'Ocpp._201.Generated.Models'

mkdir "$baseDir/Generated/C#"

foreach ($f in $names) {
    $prefix = $f.Split(".")[0];
    Write-Host "Generating sources for $prefix ($f)"
    quicktype -s schema "$baseDir/$f" -o "$baseDir/Generated/C#/$prefix.cs" --namespace "$namespace.$prefix" --csharp-version 6 --array-type list --any-type dynamic --virtual
}