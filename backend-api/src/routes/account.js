const router = new Router();
const accountBiz = require('./../biz/accountBiz');

router.get('/', (req, res) => res.send('aaa'));

module.exports = {
  router,
  priority: 0,
  prefix: '/account'
};
