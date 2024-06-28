<script>
export default {
  name: "casa",
  components: {},
  title: "Home",
}
</script>

<template>
  <div class="flex flex-column gap-2 w-full md:w-30rem justify-content-center">
    <label for="username">Username</label>
    <pv-input-text id="username" aria-describedby="username-help" />
    <small id="username-help">Enter your username to reset your password.</small>
  </div>

</template>

<style scoped>

</style>