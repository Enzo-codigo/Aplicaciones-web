import { createApp } from 'vue'
import App from './app.vue'
import PrimeVue from "primevue/config";
import Button from "primevue/button";
import Toolbar from "primevue/toolbar";
import router from "@/router/index.js";

import 'primeicons/primeicons.css'
import 'primevue/resources/themes/aura-dark-amber/theme.css'
import 'primeflex/primeflex.css'

import DataTable from "primevue/datatable";
import Column from "primevue/column";
import Row from "primevue/row";
import Card from "primevue/card";
import Avatar from "primevue/avatar";
import InputText from "primevue/inputtext";
import Dropdown from "primevue/dropdown";
import Checkbox from 'primevue/checkbox';
import InputGroup from 'primevue/inputgroup';
import InputGroupAddon from 'primevue/inputgroupaddon';
import InputNumber from "primevue/inputnumber";
import FloatLabel from "primevue/floatlabel";

createApp(App)
    .use(PrimeVue, {ripple: true})
    .use(router)
    .component('pv-button', Button)
    .component('pv-toolbar',Toolbar)
    .component('pv-data-table', DataTable)
    .component('pv-column', Column)
    .component('pv-row', Row)
    .component('pv-card', Card)
    .component('pv-avatar', Avatar)
    .component('pv-input-text', InputText)
    .component('pv-dropdown', Dropdown)
    .component('pv-input-group', InputGroup)
    .component('pv-input-addon', InputGroupAddon)
    .component('pv-input-number', InputNumber)
    .component('pv-float-label', FloatLabel)
    .mount('#app')