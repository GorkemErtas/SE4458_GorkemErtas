const express = require('express');
const bodyParser = require('body-parser');
const dotenv = require('dotenv');

dotenv.config();

const app = express();
const PORT = process.env.PORT || 3000;

app.use(bodyParser.json());

const adminRoutes = require('./src/routes/adminRoutes');
const clientRoutes = require('./src/routes/clientRoutes');

app.use('/api/v1/admin', adminRoutes);
app.use('/api/v1', clientRoutes);

app.listen(PORT, () => {
  console.log(`Server running on http://localhost:${PORT}`);
});