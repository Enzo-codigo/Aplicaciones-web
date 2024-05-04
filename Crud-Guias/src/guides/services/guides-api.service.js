import http from "@/shared/services/http-common.js";

export class GuidesApiService {
    getAll() {
        return http.get('/guides');
    }

    getById(id) {
        return http.get(`/guides/${id}`);
    }

    create(guideResource) {
        return http.post('/guides', guideResource);
    }

    update(id, guideResource) {
        return http.put(`/guides/${id}`, guideResource);
    }

    delete(id) {
        return http.delete(`/guides/${id}`);
    }
}