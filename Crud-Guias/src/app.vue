<script>
export default {
  name: "app",
  title: "Turisteando",
  data() {
    return {
      drawer: false,
      pages: [
        {label: "Home", to: "/home"},
        {label: "About", to: "/about"},
        {label: "Guides Catalogue", to: "/guides"},
        {label: "Guides Form", to: "/guide/form"},
      ]
    }
  },
  methods: {
    toggleDrawer() {
      this.drawer = !this.drawer;
    },
  }
}
</script>

<template>
  <header class="page-header">
    <pv-toolbar class="bg-primary" fixed>
      <template #start>
        <pv-button class="p-button-text text-white"
                   icon="pi pi-bars" @click="toggleDrawer"></pv-button>
        <h2>Turisteando</h2>
      </template>
      <template #end>
        <div class="flex-column">
          <router-link v-for="page in pages" :key="page.label"
                       v-slot="{ navigate, href }" :to="page.to" custom>
            <pv-button :href="href" class="p-button-text text-white"
                       @click="navigate">
              {{ page.label }}
            </pv-button>
          </router-link>
        </div>
      </template>
    </pv-toolbar>
  </header>
  <router-view></router-view>
</template>

<style scoped>

</style>