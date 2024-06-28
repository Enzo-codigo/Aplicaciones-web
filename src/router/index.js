import {createRouter, createWebHistory} from "vue-router";
import HomeComponent from "@/public/pages/home.component.vue";
import AboutComponent from "@/public/pages/about.component.vue";
import GuideCatalogueComponent from "@/guides/pages/guide-catalogue.component.vue";
import GuideFormComponent from "@/guides/components/guide-form.component.vue";

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/home', component: HomeComponent, meta: { title: 'Home' }, },
        { path: '/about', component: AboutComponent, meta: { title: 'About Us' }, },
        { path: '/guides', component: GuideCatalogueComponent, meta: { title: 'Guides Catalogue' }, },
        { path: '/guide/form', component: GuideFormComponent, meta: { title: 'Guides Form' }, },
        { path: '/',  redirect: '/home' }
    ]
});

router.beforeEach((to, from, next) => {
    let baseTitle = 'Turisteando';
    document.title = `${ baseTitle } | ${ to.meta["title"]}`;
    next();
});

export default router;