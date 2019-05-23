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


function minJs() {
	var tasks = getBundles(regex.js).map(function (bundle) {
		return gulp.src(bundle.inputFiles, { base: "." })
			.pipe(concat(bundle.outputFileName))
			.pipe(uglify())
			.pipe(gulp.dest("."));
	});
	return merge(tasks);
};


function minCss() {
	var tasks = getBundles(regex.css).map(function (bundle) {
		return gulp.src(bundle.inputFiles, { base: "." })
			.pipe(concat(bundle.outputFileName))
			.pipe(minify())
			.pipe(gulp.dest("."));
	});
	return merge(tasks);
};

/*gulp.task("min:html", function () {
	var tasks = getBundles(regex.html).map(function (bundle) {
		return gulp.src(bundle.inputFiles, { base: "." })
			.pipe(concat(bundle.outputFileName))
			.pipe(htmlmin({ collapseWhitespace: true, minifyCSS: true, minifyJS: true }))
			.pipe(gulp.dest("."));
	});
	return merge(tasks);
});*/

//module.exports.minHtml = minHtml;
module.exports.minCss = minCss;
module.exports.minJs = minJs;
module.exports.build = gulp.series(minCss, minJs/*, minHtml, */);

//exports.default = series(
//	parallel(minCss),
//	watchTask);

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



