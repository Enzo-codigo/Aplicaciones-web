<script>
import GuideCard from "@/guides/components/guide-card.component.vue";

export default {
  name: "guide-list",
  components: {GuideCard},
  props: {
    guides: Array
  }
}
</script>

<template>
  <div v-for="guide in guides">
    <guide-card :guide="guide"/>
  </div>
</template>

<style scoped>

</style>