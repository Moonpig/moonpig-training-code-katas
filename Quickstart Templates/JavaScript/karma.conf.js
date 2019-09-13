// Karma configuration
// Generated on Wed Aug 09 2017 10:07:23 GMT+0100 (GMT Summer Time)
module.exports = function (config) {
    config.set({
    // base path that will be used to resolve all patterns (eg. files, exclude)
        basePath: '',
        frameworks: ['jasmine'],
        files: [
            'app/*.js'
        ],
        exclude: [],
        // preprocess matching files before serving them to the browser
        // available preprocessors: https://npmjs.org/browse/keyword/karma-preprocessor
        preprocessors: {},
        // test results reporter to use
        // possible values: 'dots', 'progress'
        // available reporters: https://npmjs.org/browse/keyword/karma-reporter
        reporters: ['progress'],
        port: 9876,
        colors: true,
        logLevel: config.LOG_INFO,
        autoWatch: true,
        browsers: ['Chrome'],
        singleRun: false,
        concurrency: Infinity
    });
};
