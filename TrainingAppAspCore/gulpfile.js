const gulp = require("gulp");
const concat = require("gulp-concat");
const minify = require("gulp-cssmin");
const bundleconfig = require("./bundleconfig.json");
const htmlmin = require("gulp-htmlmin");
const uglify = require("gulp-uglify");
const merge = require("merge-stream");

var regex = {
	css: /\.css$/,
	html: /\.(html|htm)$/,
	js: /\.js$/
};

//function minJs() {
//	return gulp
//			.src("wwwroot/js/*.js")
//			.pipe(concat(bundle.outputFileName))
//			.pipe(uglify())
//			.pipe(gulp.dest("."));
//};

function minCss() {
	return gulp
		.src("wwwroot/css/*.css")
		.pipe(concat("wwwroot/css/bundle.css"))
		.pipe(minify())
		.pipe(gulp.dest("."));
};



//module.exports.minHtml = minHtml;
module.exports.minCss = minCss;
//module.exports.minJs = minJs;
module.exports.build = gulp.series(minCss/*, minHtml, minJs*/);

//module.exports.clean = function () {
//	var files = bundleconfig.map(function (bundle) {
//		return bundle.outputFileName;
//	});
	
//	return del(files);
//};

module.exports.watch = function () {
	getBundles(regex.js).forEach(function (bundle) {
		gulp.watch(bundle.inputFiles, ["minJs"]);
	});

	getBundles(regex.css).forEach(function (bundle) {
		gulp.watch(bundle.inputFiles, ["minCss"]);
	});

	getBundles(regex.html).forEach(function (bundle) {
		gulp.watch(bundle.inputFiles, ["minHtml"]);
	});
};

function getBundles(regexPattern) {
	return bundleconfig.filter(function (bundle) {
		return regexPattern.test(bundle.outputFileName);
	});
};



