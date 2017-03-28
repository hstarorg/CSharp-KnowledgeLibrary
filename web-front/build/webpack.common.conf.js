const path = require('path');
const webpack = require('webpack');
const { CheckerPlugin } = require('awesome-typescript-loader');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');

const util = require('./util');

module.exports = {
  entry: {
    polyfills: util.root('src/polyfills.ts'),
    vendor: util.root('src/vendor.ts'),
    app: util.root('src/main.ts')
  },
  output: {
    path: util.root('dist'),
    filename: '[name].js'
  },
  resolve: {
    extensions: ['.ts', '.js']
  },
  module: {
    rules: [
      { test: /.ts$/, use: ['awesome-typescript-loader', 'angular2-template-loader'], exclude: /node_modules/ },
      { test: /\.html$/, use: 'html-loader' },
      { test: /\.(png|jpe?g|gif|svg|woff|woff2|ttf|eot|ico)$/, loader: 'file-loader?name=assets/[name].[hash].[ext]' },
      { test: /\.css$/, use: ExtractTextPlugin.extract({ use: 'css-loader' }) },
      { test: /\.styl$/, use: ExtractTextPlugin.extract({ use: 'css-loader!stylus-loader' }) }
    ]
  },
  plugins: [
    new CheckerPlugin(),
    new webpack.optimize.CommonsChunkPlugin({
      name: ['app', 'vendor', 'polyfills']
    }),
    new HtmlWebpackPlugin({
      template: util.root('src/index.html')
    })
  ]
};
