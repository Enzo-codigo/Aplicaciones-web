<script>
import {Guide} from "@/guides/model/guide.entity.js";

export default {
  name: "guide-card",
  props:{
    guide: Guide
  }
}
</script>

<template>
  <pv-card class="m-2">
    <template #header>
      <img :alt="guide.name"
           :src="guide.picture">
    </template>
    <template #title>
      <p>{{ guide.name }}</p>
    </template>
    <template #content>
      <p class="flex align-content-start flex-wrap">
        <span class="flex align-items-center justify-content-center mr-2">
          <pv-avatar :aria-label="guide.source.name"
                     :image="guide.source.picture"
                     shape="circle"/>
        </span>
        <span class="flex align-items-center justify-content-center">
          {{ guide.source.name }}
        </span>
      </p>
      <p class="flex align-content-start flex-wrap mt-4">
        {{ guide.description}}
      </p>
    </template>
  </pv-card>
</template>

<style scoped>

</style>