const path = require('path');
const restExpress = require('rest-express');

const options = {
  port: 7410,
  enableCors: true,
  enableGzip: true,
  routesPath: path.join(__dirname, './routes'),
  apiPrefix: '/api/v1'
};

restExpress.startServer(options)
  .then(server => {
    let addr = server.address();
    console.log(`Server started at ${addr.host}:${addr.port}`);
  }, console.error);
