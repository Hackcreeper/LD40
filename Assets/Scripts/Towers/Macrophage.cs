﻿using System.Linq;
using UnityEngine;

namespace LD40.Towers
{
    public class Macrophage : Tower
    {
        private const float delay = 1.5f;

        public int StartHealth = 40;

        private float timer = delay;
        private bool active;
        private Transform target;
        private bool eating;
        private bool hasKilledAll;
        private bool dead;

        private Vector3 originalPosition;
        private Quaternion originalRotation;

        protected override void OnUpdate()
        {
            if (dead) return;

            if (!active)
            {
                var overlaps = Physics.OverlapSphere(transform.position, Radius);
                if (overlaps.Any(body =>
                    body.GetComponent<Enemy>() != null && body.GetComponent<Enemy>().IsSticky() == false &&
                    body.GetComponent<Enemy>().IsPulled() == false && body.GetComponent<Enemy>().Reserved == false))
                {
                    target = overlaps.First(body =>
                            body.GetComponent<Enemy>() != null && body.GetComponent<Enemy>().IsSticky() == false &&
                            body.GetComponent<Enemy>().IsPulled() == false &&
                            body.GetComponent<Enemy>().Reserved == false)
                        .transform;
                }

                if (target == null) return;

                target.GetComponent<Enemy>().Pull(this);
                timer = target.GetComponent<Enemy>().Damage * delay;
                active = true;
            }
            else
            {
                if (!eating)
                {
                    if (target == null)
                    {
                        active = false;
                        return;
                    }

                    if (target.GetComponent<EntityHealth>().Health <= 0)
                    {
                        active = false;
                        return;
                    }

                    transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.3f, 1.3f, 1.3f),
                        10 * Time.deltaTime);
                    if (Vector3.Distance(target.position, transform.position) <= 0.2f)
                    {
                        eating = true;
                    }
                }
                else
                {
                    if (!target)
                    {
                        eating = false;
                        target = null;
                        active = false;
                        hasKilledAll = false;
                        return;
                    }

                    if (target.GetComponent<RotationAnimation>())
                    {
                        Destroy(target.GetComponent<RotationAnimation>());
                    }

                    transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, delay / 2 * Time.deltaTime);

                    if (hasKilledAll && Vector3.Distance(transform.localScale, Vector3.one) <= 0.08f)
                    {
                        eating = false;
                        target = null;
                        active = false;
                        hasKilledAll = false;
                    }
                    else if (!hasKilledAll)
                    {
                        timer -= Time.deltaTime;
                        if (timer > 0) return;

                        target.GetComponent<EntityHealth>().Sub(Damage);

                        hasKilledAll = true;
                        timer = delay;
                    }
                }
            }
        }

        protected override void OnPlace()
        {
            originalPosition = transform.position;
            originalRotation = transform.rotation;

            var health = gameObject.AddComponent<EntityHealth>();
            health.Health = StartHealth;
            health.FakeDeath = true;

            health.OnDead += (sender, args) =>
            {
                if (target != null)
                {
                    target.GetComponent<Enemy>().Free();
                }

                dead = true;
                target = null;
                eating = false;
                hasKilledAll = false;
                active = false;
                timer = delay;

                gameObject.SetActive(false);
            };

            EnemySpawner.Instance.OnEnd += (sender, args) =>
            {
                dead = false;
                target = null;
                eating = false;
                hasKilledAll = false;
                active = false;
                timer = delay;

                gameObject.SetActive(true);
                transform.position = originalPosition;
                transform.rotation = originalRotation;

                health.Health = StartHealth;
            };
        }
    }
}