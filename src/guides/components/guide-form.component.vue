<script>
import { ref } from 'vue';
import { GuidesApiService } from "@/guides/services/guides-api.service.js";
import { Guide } from "@/guides/model/guide.entity.js";

export default {
  name: "guide-form",
  components: {

  },
  data() {
    return {
      newGuide: {
        name: '',
        destination: '',
        language: '',
        specialization: '',
        availability: '',
        rate: null,
        experience: '',
        picture: ''
      },
      guidesService: new GuidesApiService()
    }
  },
  methods: {
    async addGuide() {
      try {
        await this.guidesService.create(this.newGuide);
        // Reinicia el formulario después de agregar el guía
        this.newGuide = {
          name: '',
          destination: '',
          language: '',
          specialization: '',
          availability: '',
          rate: null,
          experience: '',
          picture: ''
        };
        // Emite un evento o realiza otra acción después de agregar el guía
      } catch (error) {
        console.error('Error adding guide:', error);
      }
    }
  }
}
</script>

<template class="form-primary">
  <br/>
  <br/>
  <div class="guide-form">
    <div class="p-field">
      <label for="name" class="lbl">Name: </label>
      <pv-input-text id="name" v-model="newGuide.name" class="p-inputtext-sm" placeholder="Ej. Miguel Angel" />
    </div>
    <div class="p-field">
      <label for="destination" class="lbl">Destination:</label>
      <pv-input-text id="destination" v-model="newGuide.destination" class="p-inputtext-sm" />
    </div>
    <div class="p-field">
      <label for="language" class="lbl">Language:</label>
      <pv-input-text id="language" v-model="newGuide.language" class="p-inputtext-sm" />
    </div>
    <div class="p-field">
      <label for="specialization" class="lbl">Specialization:</label>
      <pv-input-text id="specialization" v-model="newGuide.specialization" class="p-inputtext-sm" />
    </div>
    <div class="p-field">
      <label for="availability" class="lbl">Availability:</label>
      <pv-input-text id="availability" v-model="newGuide.availability" class="p-inputtext-sm" />
    </div>
    <div class="p-field">
      <label for="rate" class="lbl">Rate:</label>
      <pv-input-number id="rate" v-model="newGuide.rate" mode="decimal" :min="0" :max="10" class="p-inputnumber" />
    </div>
    <div class="p-field">
      <label for="experience" class="lbl">Experience:</label>
      <textarea id="experience" v-model="newGuide.experience" class="p-inputtextarea-sm" rows="3"></textarea>
    </div>
    <div class="p-field">
      <label for="picture" class="lbl">Picture URL:</label>
      <pv-input-text id="picture" v-model="newGuide.picture" class="p-inputtext-sm" />
    </div>
    <div class="p-field">
      <pv-button @click="addGuide" class="p-button-primary">Add Guide</pv-button>
    </div>
  </div>
</template>

<style scoped>
.guide-form {
  max-width: 600px;
  margin: auto;
}

.p-field {
  margin-bottom: 1rem;
}

.lbl {
  display: inline-block;
  width: 120px;
  text-align: right;

  margin-right: 10px;
}

.p-inputtext-sm,
.p-inputtextarea-sm {
  width: calc(100% - 150px);
  text-align: justify-all;
}

.p-inputtext-sm,
.p-inputtextarea-sm,
.p-inputnumber {
  font-size: 14px;
  padding: 0.5rem;
  border: 1px solid #ccc;
  border-radius: 0.25rem;
}

.p-inputtext-sm:focus,
.p-inputtextarea-sm:focus,
.p-inputnumber:focus {
  outline: none;
  border-color: #007bff;
}

.p-button-primary {
  background-color: #007bff;
  color: #fff;
  border: none;
  padding: 0.5rem 1rem;
  font-size: 1rem;
  border-radius: 0.25rem;
  cursor: pointer;
}

.p-button-primary:hover {
  background-color: #0056b3;
}

</style>