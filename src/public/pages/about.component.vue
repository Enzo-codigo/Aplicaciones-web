<script>

export default {
  name: "about",
  components: {},
  title: "About Us"
}
</script>

<template>
  <section class="content">
    <h2>Our Story</h2>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eget quam nec nisi tincidunt aliquam. Nam vestibulum auctor odio, vitae scelerisque ex vehicula id.</p>
    <h2>Our Team</h2>
    <p>Meet our amazing team!</p>
    <div class="team-member">
      <h3>John Doe</h3>
      <p>CEO</p>
    </div>
    <div class="team-member">
      <h3>Jane Smith</h3>
      <p>CTO</p>
    </div>
  </section>
  <footer>
    <p>&copy; 2024 Turisteros Venture. All rights reserved.</p>
  </footer>
</template>

<style scoped>
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
}

header {
  background-color: #333;
  color: #fff;
  padding: 20px;
  text-align: center;
}

.content {
  padding: 20px;
}

.team-member {
  text-align: center;
  margin-bottom: 20px;
}

.team-member img {
  width: 150px;
  border-radius: 50%;
  border: 3px solid #333;
}

footer {
  background-color: orange;
  color: #fff;
  text-align: center;
  padding: 10px;
  position: fixed;
  bottom: 0;
  width: 100%;
}

</style>