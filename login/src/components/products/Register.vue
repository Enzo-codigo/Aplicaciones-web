<template>
  <div class="register-container">
    <form @submit.prevent="registerUser">
      <h2 style="color: black;">Registrarse</h2>
      <div>
        <label for="fullName" style="color: black;">Nombre completo:</label>
        <input type="text" id="fullName" v-model="registerForm.fullName" required>
      </div>
      <div>
        <label for="email" style="color: black;">Email:</label>
        <input type="email" id="email" v-model="registerForm.email" required>
      </div>
      <div>
        <label for="password" style="color: black;">Contraseña:</label>
        <input type="password" id="password" v-model="registerForm.password" required>
      </div>
      <button type="submit" style="background-color: black; color: white;">Registrarse</button>
    </form>
    <p>¿Ya tienes una cuenta? <router-link to="/login">Inicia sesión aquí</router-link></p>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'Register',
  data() {
    return {
      registerForm: {
        fullName: '',
        email: '',
        password: ''
      }
    };
  },
  methods: {
    async registerUser() {
      try {
        await axios.post('http://localhost:3000/users', this.registerForm);
        this.$router.push('/login');
      } catch (error) {
        console.error('Error al registrar:', error);
      }
    }
  }
};
</script>

<style scoped>

.register-container {
  max-width: 360px;
  margin: 0 auto;
  padding: 20px;
  background-color: #f9f9f9;
  border-radius: 5px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.register-container h2 {
  font-size: 1.5rem;
  margin-bottom: 20px;
}

.register-container label {
  display: block;
  margin-bottom: 10px;
}

.register-container input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  margin-bottom: 15px;
}

.register-container button {
  width: 100%;
  padding: 10px;
  background-color: #007bff;
  color: #fff;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}

.register-container button:hover {
  background-color: #0056b3;
}
</style>
