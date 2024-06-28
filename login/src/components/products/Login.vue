<template>
  <div class="login-container">
    <form @submit.prevent="loginUser" class="login-form">
      <h2 class="login-title">Iniciar Sesión</h2>
      <div class="form-group">
        <label for="email" class="form-label">Email:</label>
        <input type="email" id="email" v-model="loginForm.email" class="form-input" required>
      </div>
      <div class="form-group">
        <label for="password" class="form-label">Contraseña:</label>
        <input type="password" id="password" v-model="loginForm.password" class="form-input" required>
      </div>
      <button type="submit" class="form-button">Iniciar Sesión</button>
    </form>
    <p class="register-link">¿No tienes una cuenta? <router-link to="/register" class="link">Regístrate aquí</router-link></p>
  </div>
</template>

<script>
export default {
  name: 'Login',
  data() {
    return {
      loginForm: {
        email: '',
        password: ''
      }
    };
  },
  methods: {
    loginUser() {

      console.log('Usuario:', this.loginForm);
    }
  }
};
</script>

<style scoped>

.login-container {
  max-width: 400px;
  margin: 0 auto;
}

.login-form {
  background-color: #f9f9f9;
  border-radius: 8px;
  padding: 20px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.login-title {
  font-size: 1.5rem;
  margin-bottom: 20px;
  text-align: center;
  color: #000; /* Color negro */
}

.form-group {
  margin-bottom: 15px;
}

.form-label {
  display: block;
  margin-bottom: 5px;
  font-weight: bold;
  color: #000; /* Color negro */
}

.form-input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
}

.form-button {
  width: 100%;
  padding: 10px;
  background-color: #007bff;
  color: #fff;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}

.form-button:hover {
  background-color: #0056b3;
}

.register-link {
  text-align: center;
  margin-top: 15px;
}

.link {
  color: #007bff;
  text-decoration: underline;
  cursor: pointer;
}

.link:hover {
  color: #0056b3;
}
</style>
