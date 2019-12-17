var gulp = require("gulp");
var config = require("./gulp-config.js")();
var _msbuild = require("msbuild");

module.exports.config = config;

gulp.task("Publish-Solution", function (callback) {
    var msbuild = new _msbuild(callback);
    msbuild.solutionName = config.solutionName;
    var overrideParams = [];
    overrideParams.push('/p:Configuration=' + config.buildConfiguration);
    overrideParams.push('/p:DeployOnBuild=true');
    overrideParams.push('/p:DeployDefaultTarget=WebPublish');
    overrideParams.push('/p:WebPublishMethod=FileSystem');
    overrideParams.push('/p:DeleteExistingFiles=false');
    overrideParams.push('/p:publishUrl=' + config.webRoot);
    msbuild.config('overrideParams', overrideParams);
    msbuild.config('version', config.toolsVersion);
    // msbuild.targets = ["Build"];
	msbuild.build(); // calls (callback) when done
});