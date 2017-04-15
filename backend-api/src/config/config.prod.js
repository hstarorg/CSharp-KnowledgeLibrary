const path = require('path');

module.exports = {
  port: 8601,
  debug: false,
  dbFolder: path.join(__dirname, '../database')
};
