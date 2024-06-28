const express = require('express');
const fs = require('fs');
const app = express();
const PORT = 3000;

app.use(express.json());

app.post('/users', (req, res) => {
    const userData = req.body;

    fs.readFile('db.json', 'utf-8', (err, data) => {
        if (err) {
            console.error(err);
            res.status(500).send('Error interno del servidor');
            return;
        }
        const users = JSON.parse(data);

        users.push(userData);
        fs.writeFile('db.json', JSON.stringify(users), (err) => {
            if (err) {
                console.error(err);
                res.status(500).send('Error interno del servidor');
                return;
            }
            res.status(201).send('Usuario registrado correctamente');
        });
    });
});

app.listen(PORT, () => {
    console.log(`Servidor corriendo en http://localhost:${PORT}`);
});
