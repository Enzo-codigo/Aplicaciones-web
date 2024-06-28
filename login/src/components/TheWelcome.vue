<script setup>

import login from "@/components/products/Login.vue";
import register from "@/components/products/Register.vue";
</script>
<template>
 <register></register>
 <login></login>/
</template>

<script>
import axios from 'axios';
export default {
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

</style>
