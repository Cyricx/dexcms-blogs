/// <binding BeforeBuild='clean' AfterBuild='copy' />
module.exports = function (grunt) {
    //Configuration setup
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        copy: {
            domain: {
                expand: true,
                cwd: 'DexCMS.Blogs/bin/Release/',
                src: ['DexCMS.Blogs.dll'],
                dest: 'dist/'
            },
            //mvc: {
            //    expand: true,
            //    cwd: 'DexCMS.Blogs.Mvc/bin/Release/',
            //    src: ['DexCMS.Blogs.Mvc.dll'],
            //    dest: 'dist/'
            //},
            webapi: {
                expand: true,
                cwd: 'DexCMS.Blogs.WebApi/bin/Release/',
                src: ['DexCMS.Blogs.WebApi.dll'],
                dest: 'dist/'
            }
        },
        clean: {
            build: ["dist"]
        }
    });

    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.registerTask('default', ['clean', 'copy']);
};
