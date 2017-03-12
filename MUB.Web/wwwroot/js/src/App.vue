<template>
    <div id="app">
        <NavBar></NavBar>
    </div>
</template>
<script>
    import NavBar from './components/NavBar.vue'

    export default {
      name: 'app',
    components: {NavBar},
      data () {
        return {
          msg: 'Welcome to Your Vue.js App'
        }
      }
    }

</script>
<style>
    #app {
    }
</style>
