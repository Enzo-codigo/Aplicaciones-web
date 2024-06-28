<script>
import { ref, computed } from 'vue';
import {GuidesApiService} from "@/guides/services/guides-api.service.js";
import {Guide} from "@/guides/model/guide.entity.js";
import GuideList from "@/guides/components/guide-list.component.vue";

export default {
  name: "guide-catalogue",
  components: {GuideList},
  title: "Guide Catalogue",
  data() {
    return {
      globalFilter: "",
      title: "Guide Catalogue",
      guides: [],
      guideDialog: false,
      deleteGuideDialog: false,
      deleteGuidesDialog: false,
      guide: null,
      selectedGuides: [],
      filters: {},
      submitted: false,
      guidesService: null,
    }
  },
  created() {
    this.guidesService = new GuidesApiService()
    this.guidesService.getAll()
        .then(response => {
          this.guides = response.data;
          this.guides = this.guides.map(guide => {
            return Guide.toDisplayableGuide(guide);
          });
        });
  },
  computed: {
    filteredGuides() {
      return this.guides.filter(guide =>
          Object.values(guide).some(val =>
              val.toString().toLowerCase().includes(this.globalFilter.toLowerCase())
          )
      );
    }
  },
  methods: {
    editGuide(guide) {
      // Lógica para editar un guía
      console.log("Edit guide:", guide);
    },
    deleteGuide(guide) {
      // Lógica para eliminar un guía
      console.log("Delete guide:", guide);
    }
  }
}
</script>

<template>
  <div class="guides">
    <div class="p-field">
      <label for="globalFilter">Search:</label>

    </div>

    <pv-data-table ref="dt" v-model:selection="selectedGuides"
                   :filters="filters"
                   :globalFilterFields="['name', 'destination', 'language', 'specialization', 'availability', 'rate']"
                   :paginator="true"
                   :rows="10"
                   :rowsPerPageOptions="[5, 10, 25]"
                   :value="filteredGuides"
                   currentPageReportTemplate="Showing {first} to {last} of {totalRecords} tutorials"
                   dataKey="id"
                   paginatorTemplate="FirstPageLink PrevPageLink
                                      PageLinks NextPageLink LastPageLink
                                      CurrentPageReport  RowsPerPageDropdown"
                   responsiveLayout="scroll">
      <pv-column field="name" header="Name"></pv-column>
      <pv-column field="destination" header="Destination"></pv-column>
      <pv-column field="language" header="Language"></pv-column>
      <pv-column field="specialization" header="Specialization"></pv-column>
      <pv-column field="availability" header="Availability"></pv-column>
      <pv-column field="rate" header="Rate"></pv-column>
      <pv-column header="Picture">
        <template v-slot="rowData">
          <img :src="rowData.picture" alt="Guide Picture" style="width: 100px; height: auto;">
        </template>
      </pv-column>
    </pv-data-table>
  </div>
</template>

<style scoped>
.p-field {
  margin-bottom: 1rem;
}
</style>