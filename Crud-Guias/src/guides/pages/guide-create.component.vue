<script>
import GuideForm from "@/guides/components/guide-form.component.vue";

export default {
  name: "guide-create",
  components: {GuideForm}
}
</script>

<template>
  <div class="form-guide-pv">
    <guide-form></guide-form>
  </div>
</template>

<style scoped>
.form-guide-pv {
  display: flex;
  background-image: url(https://cuscoperuadventure.com/wp-content/uploads/2017/12/IMG_20160428_114931250.jpg);
  background-repeat: no-repeat;
  background-size: cover; /* La imagen de fondo cubrirá todo el contenedor*/
  background-position: center; /* La imagen de fondo se posicionará centrada */
}
</style>