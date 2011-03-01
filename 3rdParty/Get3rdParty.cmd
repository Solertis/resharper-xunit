@echo off

SET ProgFiles=%ProgramFiles(x86)%
if "%ProgFiles%"=="" SET ProgFiles=%ProgramFiles%

echo %ProgFiles%

if not exist "%ProgFiles%\JetBrains\Resharper\v4.1\bin" goto CopyResharper_v45

mkdir ReSharper_v4.1
cd ReSharper_v4.1
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Annotations.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.DocumentManager.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.IDE.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.MetaData.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.ProjectModel.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.Shell.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.Resharper.UI.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.Platform.ReSharper.Util.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.CodeInsight.Services.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.CodeView.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.Psi.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.TaskRunnerFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.TestFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.1\Bin\JetBrains.ReSharper.UnitTestExplorer.???" > nul
cd ..
echo Support for ReSharper 4.1 successfully copied.

:CopyResharper_v45

if not exist "%ProgFiles%\JetBrains\Resharper\v4.5\bin" goto CopyResharper_v50

mkdir ReSharper_v4.5
cd ReSharper_v4.5
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Annotations.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.DocumentManager.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.IDE.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.MetaData.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.ProjectModel.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.Shell.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.Resharper.UI.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.Platform.ReSharper.Util.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.Daemon.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.Feature.Services.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.Features.Common.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.Psi.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.TaskRunnerFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.TestFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v4.5\Bin\JetBrains.ReSharper.UnitTestExplorer.???" > nul
cd ..
echo Support for ReSharper 4.5 successfully copied.

:CopyResharper_v50

if not exist "%ProgFiles%\JetBrains\Resharper\v5.0\bin" goto CopyResharper_v51

mkdir ReSharper_v5.0
cd ReSharper_v5.0
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Annotations.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.DocumentManager.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.IDE.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.MetaData.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.ProjectModel.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.Shell.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.Resharper.UI.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.Platform.ReSharper.Util.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.Daemon.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.Features.Common.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.Feature.Services.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.Psi.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.TaskRunnerFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.UnitTestExplorer.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.0\Bin\JetBrains.ReSharper.UnitTestFramework.???" > nul
cd ..
echo Support for ReSharper 5.0 successfully copied.

:CopyResharper_v51

if not exist "%ProgFiles%\JetBrains\Resharper\v5.1\bin" goto End

mkdir ReSharper_v5.1
cd ReSharper_v5.1
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Annotations.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.DocumentManager.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.IDE.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.MetaData.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.ProjectModel.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.Shell.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.Resharper.UI.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.Platform.ReSharper.Util.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.Daemon.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.Features.Common.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.Feature.Services.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.Psi.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.TaskRunnerFramework.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.UnitTestExplorer.???" > nul
copy "%ProgFiles%\JetBrains\ReSharper\v5.1\Bin\JetBrains.ReSharper.UnitTestFramework.???" > nul
cd ..
echo Support for ReSharper 5.1 successfully copied.

goto End

:End
