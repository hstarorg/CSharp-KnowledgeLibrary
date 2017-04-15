require('shelljs/global');
const notifier = require('node-notifier');
const gulp = require('gulp4');
const devServer = require('gulp-develop-server');

const notify = (message, err) => {
  return notifier.notify({
    title: 'Notify',
    message: `${message}! ${err ? 'Has some error!' : ''}`
  });
};

gulp.task('serve', done => {
  devServer.listen({ path: 'src/index.js' }, err => {
    if (err) { console.error(err) };
    notify('Serve service ok', err);
    done();
  });
});

gulp.task('restart', done => {
  devServer.restart(err => {
    if (err) { console.error(err) };
    notify('Restart ok', err);
    done();
  });
});

gulp.task('watch', done => {
  gulp.watch([
    'src/**'
  ], gulp.series('restart'));
  done();
});

gulp.task('default', gulp.parallel('serve', 'watch'));
