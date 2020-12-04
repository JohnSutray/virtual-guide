const express = require('express');
express()
  .use(express.static('./Build/'))
  .use(express.static('./TemplateData/'))
  .use(express.static('./'))
  .listen(process.env.PORT || 5000);
