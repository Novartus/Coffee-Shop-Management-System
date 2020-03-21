param($installPath, $toolsPath, $package, $project)

$timeToInstall = "$toolsPath\installed.dat"

If(Test-Path $timeToInstall -PathType Leaf){
    Exit
}

New-Item -Path $timeToInstall -ItemType file -Force -ErrorAction Ignore > $null

$files = Get-ChildItem $installPath -Include EASendMail*.dll, EASendMail*.winmd -recurse
foreach($file in $files)
{
    $file.CreationTime = Get-Date
    $file.LastWriteTime = Get-Date
    $file.LastAccessTime = Get-Date
}